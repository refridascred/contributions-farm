-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, label, owner, level) VALUES (25, 'fallback', 'fallback', 65);
INSERT INTO layout_items (active, label, owner, level) VALUES (69, 'latest', 'open', 25);
INSERT INTO layout_items (active, label, owner, level) VALUES (8, 'blue', 'fallback', 66);
