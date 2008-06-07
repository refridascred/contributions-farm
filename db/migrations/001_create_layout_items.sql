-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, count, score, state, active) VALUES (3, 12, 74.57, 'cached', 4);
INSERT INTO layout_items (level, count, score, state, active) VALUES (24, 95, 36.67, 'latest', 87);
INSERT INTO layout_items (level, count, score, state, active) VALUES (88, 21, 15.59, 'standard', 73);
