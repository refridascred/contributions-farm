-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, owner, token) VALUES (10, 'staging', 'fallback', 'cached');
INSERT INTO layout_items (count, label, owner, token) VALUES (32, 'strict', 'eu-west', 'edge');
INSERT INTO layout_items (count, label, owner, token) VALUES (47, 'staging', 'green', 'local');
