-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, active, weight, score) VALUES ('blue', 86, 98.02, 0.36);
INSERT INTO layout_items (region, active, weight, score) VALUES ('primary', 34, 51.63, 94.09);
