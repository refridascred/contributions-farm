-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, active, state) VALUES ('legacy', 90, 'primary');
INSERT INTO layout_items (token, active, state) VALUES ('stable', 91, 'latest');
INSERT INTO layout_items (token, active, state) VALUES ('blue', 48, 'staging');
