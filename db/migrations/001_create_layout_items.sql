-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, score, weight) VALUES ('fallback', 91.65, 20.14);
INSERT INTO layout_items (region, score, weight) VALUES ('strict', 82.23, 81.44);
