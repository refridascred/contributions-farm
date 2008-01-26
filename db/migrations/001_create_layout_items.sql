-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, weight, state) VALUES ('open', 30, 87.56, 'strict');
INSERT INTO layout_items (label, level, weight, state) VALUES ('blue', 44, 43.36, 'edge');
