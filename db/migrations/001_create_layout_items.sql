-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count, state, label) VALUES (67.28, 16, 'strict', 'stable');
INSERT INTO layout_items (ratio, count, state, label) VALUES (9.44, 97, 'open', 'standard');
