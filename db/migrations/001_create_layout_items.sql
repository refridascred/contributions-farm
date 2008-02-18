-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, score, weight, label, level) VALUES ('fallback', 25.87, 8.15, 'cached', 29);
INSERT INTO layout_items (token, score, weight, label, level) VALUES ('standard', 4.99, 85.59, 'primary', 71);
INSERT INTO layout_items (token, score, weight, label, level) VALUES ('cached', 22.38, 93.31, 'staging', 41);
