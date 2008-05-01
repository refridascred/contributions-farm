-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, level, owner, token) VALUES ('fallback', 95, 'local', 'cached');
INSERT INTO layout_items (label, level, owner, token) VALUES ('legacy', 11, 'eu-west', 'open');
