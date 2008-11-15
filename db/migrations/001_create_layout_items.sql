-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner) VALUES (16.36, 'blue');
INSERT INTO layout_items (ratio, owner) VALUES (42.14, 'blue');
INSERT INTO layout_items (ratio, owner) VALUES (4.8, 'fallback');
