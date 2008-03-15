-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, ratio, region, weight) VALUES ('latest', 34.97, 'open', 13.55);
