-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, region, state, active, level) VALUES ('latest', 'legacy', 'cached', 68, 99);
INSERT INTO layout_items (label, region, state, active, level) VALUES ('standard', 'blue', 'eu-west', 9, 10);
