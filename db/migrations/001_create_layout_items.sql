-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, label, owner, active) VALUES (32, 'strict', 'eu-west', 12);
INSERT INTO layout_items (level, label, owner, active) VALUES (63, 'strict', 'edge', 82);
INSERT INTO layout_items (level, label, owner, active) VALUES (20, 'local', 'strict', 70);
