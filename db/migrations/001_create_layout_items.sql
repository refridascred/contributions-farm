-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, label, owner, token) VALUES (24.13, 'edge', 'strict', 'legacy');
INSERT INTO layout_items (ratio, label, owner, token) VALUES (67.43, 'eu-west', 'stable', 'legacy');
