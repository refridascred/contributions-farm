-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, token) VALUES ('eu-west', 37, 'eu-west');
INSERT INTO layout_items (owner, count, token) VALUES ('open', 21, 'blue');
