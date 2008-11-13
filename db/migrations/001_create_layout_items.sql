-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, count, rank, active, state) VALUES (90, 11, 10, 63, 'green');
INSERT INTO layout_items (level, count, rank, active, state) VALUES (25, 67, 37, 36, 'open');
INSERT INTO layout_items (level, count, rank, active, state) VALUES (3, 0, 62, 95, 'blue');
