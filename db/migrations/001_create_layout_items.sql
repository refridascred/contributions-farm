-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, state, count, active) VALUES ('fallback', 'primary', 53, 39);
INSERT INTO layout_items (region, state, count, active) VALUES ('cached', 'edge', 73, 44);
INSERT INTO layout_items (region, state, count, active) VALUES ('blue', 'fallback', 73, 54);
