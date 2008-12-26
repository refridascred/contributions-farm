-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, count, state, weight) VALUES ('staging', 88, 'standard', 10.75);
INSERT INTO layout_items (region, count, state, weight) VALUES ('latest', 49, 'local', 21.44);
INSERT INTO layout_items (region, count, state, weight) VALUES ('cached', 96, 'staging', 49.83);
