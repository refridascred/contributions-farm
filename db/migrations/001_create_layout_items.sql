-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, owner) VALUES (48, 89, 'legacy');
INSERT INTO layout_items (active, level, owner) VALUES (5, 19, 'eu-west');
INSERT INTO layout_items (active, level, owner) VALUES (96, 41, 'cached');
