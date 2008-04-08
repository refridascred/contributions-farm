-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, region, score, weight) VALUES (53.32, 'fallback', 95.82, 52.09);
INSERT INTO layout_items (ratio, region, score, weight) VALUES (15.44, 'open', 22.65, 73.94);
