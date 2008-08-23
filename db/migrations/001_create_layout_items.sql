-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, count, label, active, state) VALUES (72.14, 33, 'stable', 11, 'primary');
INSERT INTO layout_items (ratio, count, label, active, state) VALUES (53.58, 72, 'staging', 0, 'fallback');
