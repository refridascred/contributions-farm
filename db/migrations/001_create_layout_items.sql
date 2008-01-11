-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, region, active, state) VALUES ('open', 'latest', 36, 'cached');
INSERT INTO layout_items (label, region, active, state) VALUES ('green', 'blue', 73, 'blue');
INSERT INTO layout_items (label, region, active, state) VALUES ('green', 'stable', 91, 'stable');
