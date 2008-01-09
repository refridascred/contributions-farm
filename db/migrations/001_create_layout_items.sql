-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, state, region, level) VALUES ('fallback', 'green', 'fallback', 15);
INSERT INTO layout_items (label, state, region, level) VALUES ('edge', 'primary', 'stable', 0);
INSERT INTO layout_items (label, state, region, level) VALUES ('open', 'primary', 'legacy', 34);
