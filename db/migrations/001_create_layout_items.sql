-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, rank, owner) VALUES (93.0, 'eu-west', 74, 'legacy');
INSERT INTO layout_items (weight, region, rank, owner) VALUES (87.62, 'eu-west', 56, 'latest');
INSERT INTO layout_items (weight, region, rank, owner) VALUES (66.62, 'green', 25, 'local');
