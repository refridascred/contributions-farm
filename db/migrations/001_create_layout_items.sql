-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, rank, label, state, level) VALUES ('staging', 83, 'legacy', 'latest', 96);
INSERT INTO layout_items (region, rank, label, state, level) VALUES ('primary', 49, 'primary', 'legacy', 25);
INSERT INTO layout_items (region, rank, label, state, level) VALUES ('open', 42, 'cached', 'edge', 85);
