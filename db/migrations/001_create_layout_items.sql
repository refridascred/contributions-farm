-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, state, level) VALUES ('open', 'blue', 41);
INSERT INTO layout_items (label, state, level) VALUES ('edge', 'edge', 16);
INSERT INTO layout_items (label, state, level) VALUES ('green', 'standard', 21);
