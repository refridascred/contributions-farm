-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, count) VALUES ('latest', 'staging', 84);
INSERT INTO layout_items (owner, token, count) VALUES ('legacy', 'green', 69);
INSERT INTO layout_items (owner, token, count) VALUES ('local', 'standard', 39);
