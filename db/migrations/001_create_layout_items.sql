-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, label, level) VALUES ('staging', 'eu-west', 95);
INSERT INTO layout_items (state, label, level) VALUES ('legacy', 'staging', 73);
INSERT INTO layout_items (state, label, level) VALUES ('staging', 'latest', 42);
