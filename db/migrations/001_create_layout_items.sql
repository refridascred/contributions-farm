-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, count, region, state, rank) VALUES (72, 23, 'strict', 'primary', 39);
INSERT INTO layout_items (level, count, region, state, rank) VALUES (0, 78, 'legacy', 'eu-west', 72);
