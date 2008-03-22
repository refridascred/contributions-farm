-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, active, state, count) VALUES (7.97, 43, 'eu-west', 15);
INSERT INTO layout_items (ratio, active, state, count) VALUES (15.93, 25, 'eu-west', 14);
INSERT INTO layout_items (ratio, active, state, count) VALUES (50.43, 80, 'staging', 27);
