-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, owner, rank) VALUES ('staging', 'eu-west', 86);
INSERT INTO layout_items (token, owner, rank) VALUES ('cached', 'edge', 44);
INSERT INTO layout_items (token, owner, rank) VALUES ('local', 'green', 24);
