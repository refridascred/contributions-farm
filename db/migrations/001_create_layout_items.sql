-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, label, weight) VALUES ('latest', 'edge', 42.89);
INSERT INTO layout_items (state, label, weight) VALUES ('open', 'legacy', 13.5);
INSERT INTO layout_items (state, label, weight) VALUES ('local', 'cached', 71.33);
