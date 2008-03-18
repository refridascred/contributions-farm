-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, state, owner) VALUES ('staging', 37, 'latest', 'strict');
