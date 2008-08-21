-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, rank, label, level, count) VALUES ('standard', 68, 'latest', 75, 87);
INSERT INTO layout_items (state, rank, label, level, count) VALUES ('primary', 58, 'edge', 60, 85);
