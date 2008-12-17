-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, weight, score, count, active) VALUES ('eu-west', 0.4, 78.36, 47, 85);
INSERT INTO layout_items (region, weight, score, count, active) VALUES ('open', 62.49, 42.86, 88, 48);
