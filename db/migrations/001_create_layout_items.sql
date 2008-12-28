-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, ratio, weight) VALUES ('local', 17.62, 86.46);
INSERT INTO layout_items (region, ratio, weight) VALUES ('fallback', 3.82, 76.72);
