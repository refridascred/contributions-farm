-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, active, state, weight) VALUES ('staging', 73, 'fallback', 75.61);
INSERT INTO layout_items (region, active, state, weight) VALUES ('cached', 59, 'strict', 10.34);
INSERT INTO layout_items (region, active, state, weight) VALUES ('cached', 97, 'stable', 42.2);
