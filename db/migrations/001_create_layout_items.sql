-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, rank, label) VALUES (19.7, 21, 'latest');
INSERT INTO layout_items (weight, rank, label) VALUES (51.87, 87, 'staging');
INSERT INTO layout_items (weight, rank, label) VALUES (11.58, 46, 'fallback');
