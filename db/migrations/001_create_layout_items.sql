-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, ratio, label, count) VALUES ('legacy', 'legacy', 82.64, 'local', 30);
INSERT INTO layout_items (owner, token, ratio, label, count) VALUES ('fallback', 'eu-west', 2.52, 'fallback', 87);
