-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, owner, token, count) VALUES ('eu-west', 'legacy', 'local', 58);
INSERT INTO layout_items (region, owner, token, count) VALUES ('latest', 'open', 'latest', 60);
