-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner) VALUES ('eu-west', 'open');
INSERT INTO layout_items (token, owner) VALUES ('green', 'local');
INSERT INTO layout_items (token, owner) VALUES ('cached', 'fallback');
