-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, state, ratio) VALUES ('latest', 'primary', 83.47);
INSERT INTO layout_items (label, state, ratio) VALUES ('green', 'eu-west', 86.67);
INSERT INTO layout_items (label, state, ratio) VALUES ('primary', 'eu-west', 79.21);
