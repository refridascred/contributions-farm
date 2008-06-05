-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, region, ratio) VALUES (24.9, 24.77, 'local', 58.07);
INSERT INTO layout_items (weight, score, region, ratio) VALUES (20.23, 0.01, 'open', 13.09);
INSERT INTO layout_items (weight, score, region, ratio) VALUES (78.68, 45.09, 'standard', 26.16);
