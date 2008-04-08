-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, level, active, state, region) VALUES (55, 23, 16, 'staging', 'strict');
INSERT INTO layout_items (count, level, active, state, region) VALUES (44, 88, 88, 'fallback', 'staging');
INSERT INTO layout_items (count, level, active, state, region) VALUES (9, 27, 53, 'strict', 'green');
