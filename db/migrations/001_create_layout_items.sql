-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, region) VALUES (29, 59, 'strict');
INSERT INTO layout_items (active, rank, region) VALUES (18, 87, 'primary');
