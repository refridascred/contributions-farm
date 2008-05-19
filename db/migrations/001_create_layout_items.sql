-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, state, owner, weight, level) VALUES (94, 'open', 'open', 67.81, 24);
INSERT INTO layout_items (count, state, owner, weight, level) VALUES (79, 'green', 'standard', 11.52, 75);
