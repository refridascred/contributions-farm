-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, ratio, active, state) VALUES (35, 21, 38.67, 87, 'standard');
INSERT INTO layout_items (level, rank, ratio, active, state) VALUES (91, 62, 4.09, 38, 'legacy');
INSERT INTO layout_items (level, rank, ratio, active, state) VALUES (38, 42, 50.54, 92, 'strict');
