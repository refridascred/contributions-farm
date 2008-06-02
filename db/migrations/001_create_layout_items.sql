-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, label, count) VALUES ('edge', 'cached', 'fallback', 67);
INSERT INTO layout_items (region, state, label, count) VALUES ('open', 'legacy', 'cached', 66);
INSERT INTO layout_items (region, state, label, count) VALUES ('standard', 'local', 'eu-west', 73);
