-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, ratio, active, token) VALUES (41.49, 38.84, 2, 'open');
INSERT INTO layout_items (weight, ratio, active, token) VALUES (42.57, 89.14, 52, 'strict');
