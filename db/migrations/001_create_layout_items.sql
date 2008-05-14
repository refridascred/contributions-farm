-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, level, rank, active, state) VALUES (31.18, 70, 45, 30, 'edge');
INSERT INTO layout_items (ratio, level, rank, active, state) VALUES (57.47, 60, 64, 75, 'fallback');
INSERT INTO layout_items (ratio, level, rank, active, state) VALUES (97.03, 85, 68, 10, 'primary');
