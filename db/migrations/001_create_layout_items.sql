-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, token, active, weight) VALUES ('primary', 'local', 80, 90.19);
INSERT INTO layout_items (state, token, active, weight) VALUES ('staging', 'edge', 81, 74.05);
INSERT INTO layout_items (state, token, active, weight) VALUES ('open', 'green', 70, 74.29);
