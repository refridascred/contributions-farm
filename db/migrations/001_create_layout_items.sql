-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, ratio, token) VALUES ('staging', 47.34, 'blue');
INSERT INTO layout_items (owner, ratio, token) VALUES ('local', 30.22, 'primary');
