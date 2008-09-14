-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, state, region, label, rank) VALUES (93, 'green', 'strict', 'edge', 87);
INSERT INTO layout_items (level, state, region, label, rank) VALUES (51, 'green', 'cached', 'fallback', 89);
INSERT INTO layout_items (level, state, region, label, rank) VALUES (5, 'legacy', 'green', 'strict', 91);
