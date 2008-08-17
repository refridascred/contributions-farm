-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, label, level) VALUES ('green', 'staging', 'stable', 70);
INSERT INTO layout_items (owner, token, label, level) VALUES ('cached', 'local', 'blue', 56);
INSERT INTO layout_items (owner, token, label, level) VALUES ('fallback', 'open', 'latest', 33);
