-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, level, owner, weight, score) VALUES ('primary', 81, 'legacy', 24.38, 83.93);
INSERT INTO layout_items (region, level, owner, weight, score) VALUES ('latest', 91, 'legacy', 73.6, 65.1);
INSERT INTO layout_items (region, level, owner, weight, score) VALUES ('latest', 73, 'fallback', 93.48, 68.63);
