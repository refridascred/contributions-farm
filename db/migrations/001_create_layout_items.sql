-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, ratio, state, active) VALUES ('edge', 48.01, 'strict', 12);
INSERT INTO layout_items (region, ratio, state, active) VALUES ('staging', 89.84, 'local', 79);
