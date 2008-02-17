-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, active) VALUES ('cached', 'cached', 53);
INSERT INTO layout_items (region, state, active) VALUES ('latest', 'fallback', 22);
INSERT INTO layout_items (region, state, active) VALUES ('local', 'green', 62);
