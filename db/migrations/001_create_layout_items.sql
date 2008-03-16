-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, rank, token) VALUES (90.21, 4, 'stable');
INSERT INTO layout_items (weight, rank, token) VALUES (52.14, 98, 'open');
INSERT INTO layout_items (weight, rank, token) VALUES (29.15, 92, 'staging');
