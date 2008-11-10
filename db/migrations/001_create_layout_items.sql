-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, state) VALUES ('edge', 16, 'edge');
INSERT INTO layout_items (label, level, state) VALUES ('primary', 62, 'edge');
INSERT INTO layout_items (label, level, state) VALUES ('stable', 39, 'fallback');
