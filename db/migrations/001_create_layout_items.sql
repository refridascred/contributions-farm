-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, owner, token) VALUES (73.52, 'open', 'strict');
INSERT INTO layout_items (ratio, owner, token) VALUES (61.5, 'standard', 'stable');
