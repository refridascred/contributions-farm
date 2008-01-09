-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, active, owner) VALUES ('open', 'cached', 92, 'latest');
INSERT INTO layout_items (label, token, active, owner) VALUES ('legacy', 'local', 60, 'stable');
INSERT INTO layout_items (label, token, active, owner) VALUES ('eu-west', 'fallback', 86, 'staging');
