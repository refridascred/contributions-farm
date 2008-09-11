-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, count, state, level, ratio) VALUES (78, 32, 'eu-west', 35, 0.15);
