-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, owner, region, label, token) VALUES (39, 'staging', 'green', 'green', 'eu-west');
INSERT INTO layout_items (active, owner, region, label, token) VALUES (46, 'strict', 'staging', 'blue', 'legacy');
INSERT INTO layout_items (active, owner, region, label, token) VALUES (86, 'staging', 'eu-west', 'green', 'primary');
