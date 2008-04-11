-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, owner, ratio, token) VALUES (25, 'latest', 18.73, 'staging');
INSERT INTO layout_items (active, owner, ratio, token) VALUES (77, 'green', 49.46, 'blue');
